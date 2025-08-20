package com.example.demo.service;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;
import org.springframework.web.reactive.function.client.WebClient;

import com.example.demo.models.AggregatedOrder;
import com.example.demo.models.Order;
import com.example.demo.models.Product;
import com.example.demo.models.User;

import reactor.core.publisher.Flux;
import reactor.core.publisher.Mono;

@Service
public class AggregatorService {

	@Autowired
    private final WebClient webClient;

    public AggregatorService(WebClient.Builder webClientBuilder) {
        this.webClient = webClientBuilder.build();
    }

    public Flux<AggregatedOrder> getAggregatedOrders() {
        return webClient.get()
            .uri("lb://ORDER-MICRO-2/orders")
            .retrieve()
            .bodyToFlux(Order.class)
            .flatMap(order -> {
                Mono<User> userMono = webClient.get()
                    .uri("lb://USER-MICRO-1/users", order.getUserId())
                    .retrieve()
                    .bodyToMono(User.class);

                Mono<Product> productMono = webClient.get()
                    .uri("lb://PRODUCT-MICRO-3/products", order.getProductId())
                    .retrieve()
                    .bodyToMono(Product.class);

                return Mono.zip(userMono, productMono)
                    .map(tuple -> {
                        User user = tuple.getT1();
                        Product product = tuple.getT2();

                        AggregatedOrder aggregated = new AggregatedOrder();
                        aggregated.setOrderId(order.getId());
                        aggregated.setUserId(order.getUserId());
                        aggregated.setProductId(order.getProductId());
                        aggregated.setOrderDate(order.getOrderDate().toString());
                        aggregated.setQuantity(order.getQuantity());
                        aggregated.setTotalAmount(order.getTotalAmount());

                        aggregated.setUserName(user.getName());
                        aggregated.setUserEmail(user.getEmail());

                        aggregated.setProductName(product.getName());
                        aggregated.setProductDescription(product.getDescription());
                        aggregated.setProductPrice(product.getPrice());

                        return aggregated;
                    });
            });
    }
}
