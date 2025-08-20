package com.example.springdatajpa.controllers;

import java.util.List;
import java.util.Optional;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import com.example.springdatajpa.entities.Employee;
import com.example.springdatajpa.services.EmployeeService;

@RestController
@RequestMapping("/api")
public class EmployeeRestController {
    @Autowired
	private EmployeeService employeeService;
    
    @GetMapping("/employees")
	public List<Employee> getAllEmps(){
		return employeeService.getAllEmps();
	}
	
    @GetMapping("/employees/{id}")
    public Optional<Employee> getEmpByID(@PathVariable("id") int eid){
    	return employeeService.getEmpById(eid);
    }
    
    @PostMapping("/employees")
    public Employee createEmp(@RequestBody Employee emp) {
    	return employeeService.save(emp); // id = null
    }
    
    @PutMapping("/employees")
    public Employee updateEmp(@RequestBody Employee emp) {
    	return employeeService.save(emp); // id != null
    }
    
    @DeleteMapping("/employees/{id}")
    public String deleteEmpByID(@PathVariable("id") int eid) {
    	employeeService.deleteEmpById(eid);
    	return "Employee with ID: "+eid+" deleted!";
    }
    
    @GetMapping("/employees/pay/{pay}")
	public List<Employee> getAllEmpsByPAy(@PathVariable("pay") double pay){
		return employeeService.getEmpsByPay(pay);
	}
}
