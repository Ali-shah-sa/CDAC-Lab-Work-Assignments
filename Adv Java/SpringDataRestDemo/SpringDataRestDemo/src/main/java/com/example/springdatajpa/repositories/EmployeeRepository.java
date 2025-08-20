package com.example.springdatajpa.repositories;

import java.util.List;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import com.example.springdatajpa.entities.Employee;

@Repository
public interface EmployeeRepository extends JpaRepository<Employee, Integer>{
	// all crud + other methods available for free
	
	//public List<Employee> getEmployeesByPay(double pay);
}
