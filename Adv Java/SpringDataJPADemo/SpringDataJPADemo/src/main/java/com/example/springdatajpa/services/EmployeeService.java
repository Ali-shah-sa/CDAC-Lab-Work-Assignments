package com.example.springdatajpa.services;

import java.util.List;
import java.util.Optional;

import com.example.springdatajpa.entities.Employee;

public interface EmployeeService {
	
	public List<Employee> getAllEmps();
	public Optional<Employee> getEmpById(int id);
	public Employee save(Employee emp); // for both creaton and updation
	public void deleteEmpById(int id);
	public List<Employee> getEmpsByPay(double pay);
	

}
