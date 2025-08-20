package com.example.springdatajpa.services;

import java.util.List;
import java.util.Optional;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.example.springdatajpa.entities.Employee;
import com.example.springdatajpa.repositories.EmployeeRepository;

import jakarta.transaction.Transactional;

@Service
@Transactional
public class EmployeeServiceImpl implements EmployeeService {
	
	@Autowired
	private EmployeeRepository employeeRepository;

	@Override
	public List<Employee> getAllEmps() {
		return employeeRepository.findAll();
	}

	@Override
	public Optional<Employee> getEmpById(int id) {
		return employeeRepository.findById(id);
	}

	@Override
	public Employee save(Employee emp) {
		return employeeRepository.save(emp); // 
	}

	@Override
	public void deleteEmpById(int id) {
	   employeeRepository.deleteById(id);
	}

	@Override
	public List<Employee> getEmpsByPay(double pay) {
		return employeeRepository.getEmployeesByPay(pay);
	}
	
	

}
