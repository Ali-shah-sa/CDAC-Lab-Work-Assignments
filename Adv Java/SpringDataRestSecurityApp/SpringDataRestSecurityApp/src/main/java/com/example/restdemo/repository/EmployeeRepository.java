package com.example.restdemo.repository;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.rest.core.annotation.RepositoryRestResource;
import org.springframework.stereotype.Repository;

import com.example.restdemo.entity.Employee;

@Repository
//@RepositoryRestResource(path="members")
public interface EmployeeRepository extends JpaRepository<Employee,Integer>{

	// provides CRUD methods
	
}
