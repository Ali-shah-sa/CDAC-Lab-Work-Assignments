package com.example.spring.dao;

import java.util.List;

import com.example.spring.entity.Student;

public interface StudentDao {

	// CRUD methods
	
	public Student save(Student student);  // Create
	
	public Student getStudentById(int id); // Read - by ID
	
	public List<Student> getAllStudents(); // Read
	
	public Student update(Student student); // Update
	
	public void delete(int id); // Delete
}
