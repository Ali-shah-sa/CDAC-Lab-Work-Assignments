package com.example.empdir.restcontroller;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import com.example.empdir.entity.Employee;
import com.example.empdir.service.EmployeeService;

@RestController
@RequestMapping("/api")
public class EmployeeRestController {

	// web services or rest API / restful API
	// Inject EmployeeeService
	
	@Autowired
	private EmployeeService employeeService;
	
	@GetMapping("/employees")
	public List<Employee> getAllEmployees(){
		return employeeService.findAllEmp();  // 
		
	}
	
}
