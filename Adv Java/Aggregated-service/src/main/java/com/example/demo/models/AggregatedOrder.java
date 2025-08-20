package com.example.demo.models;

import lombok.Data;

import lombok.Data;

@Data
public class AggregatedOrder {

    // From Order
    private Long orderId;
    private Long userId;
    private Long productId;
    private String orderDate;
    private Integer quantity;
    private Double totalAmount;

    // From User
    private String userName;
    private String userEmail;

    // From Product
    private String productName;
    private String productDescription;
    private Double productPrice;
}
