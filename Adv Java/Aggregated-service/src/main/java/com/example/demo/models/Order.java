package com.example.demo.models;

import java.time.LocalDateTime;

import lombok.Data;

@Data
public class Order {
    private Long id;
    private Long userId;
    private Long productId;
    private LocalDateTime orderDate;
    private Integer quantity;
    private Double totalAmount;
}
