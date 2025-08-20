package com.example.jpa.entity;

import jakarta.persistence.Column;
import jakarta.persistence.Entity;
import jakarta.persistence.GeneratedValue;
import jakarta.persistence.GenerationType;
import jakarta.persistence.Id;
import jakarta.persistence.Table;
import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

@Data
@AllArgsConstructor
@NoArgsConstructor
@Entity
@Table(name="emp")
public class Employee {
    @Id
    @GeneratedValue(strategy=GenerationType.IDENTITY)
	private int id;
	
    @Column(name="fname")
	private String firstName;
	@Column(name="lname")
	private String lastName;
	
	private String email;
	
}
