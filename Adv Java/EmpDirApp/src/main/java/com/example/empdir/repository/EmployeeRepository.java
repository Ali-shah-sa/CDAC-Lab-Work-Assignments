package com.example.empdir.repository;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import com.example.empdir.entity.Employee;

@Repository
public interface EmployeeRepository extends JpaRepository<Employee, Integer>{

	// ALL CRUD methods are available for free
}
