package com.example.empdir.service;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.example.empdir.entity.Employee;
import com.example.empdir.repository.EmployeeRepository;

@Service
public class EmployeeServiceImpl implements EmployeeService{

	@Autowired
	private EmployeeRepository employeeRepository;  // instance available here
	
	@Override
	public List<Employee> findAllEmp() {
		return employeeRepository.findAll();  // free method provided JpaRepository
	}

}
