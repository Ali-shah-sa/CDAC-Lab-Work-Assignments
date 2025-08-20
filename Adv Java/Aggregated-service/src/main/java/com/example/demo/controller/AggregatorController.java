package com.example.demo.controller;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import com.example.demo.models.AggregatedOrder;
import com.example.demo.service.AggregatorService;

import reactor.core.publisher.Mono;

@RestController
@RequestMapping("/aggregated")
public class AggregatorController {

    @Autowired
    private AggregatorService aggregatorService;

    @GetMapping
    public Mono<ResponseEntity<List<AggregatedOrder>>> getAllOrders() {
        return aggregatorService.getAggregatedOrders()
                .collectList()                  // collect Flux to List
                .map(ResponseEntity::ok);       // wrap list in ResponseEntity
    }

}

