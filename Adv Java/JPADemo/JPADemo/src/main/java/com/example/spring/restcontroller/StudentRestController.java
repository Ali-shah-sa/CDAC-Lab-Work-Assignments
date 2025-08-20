package com.example.spring.restcontroller;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import com.example.spring.dao.StudentDao;
import com.example.spring.entity.Student;

@RestController
@RequestMapping("/api")
public class StudentRestController {
	
	@Autowired
	private StudentDao studentDao;  // using interface => its implementation class is injected
	
	@PostMapping("/students")
	public Student createStudent(@RequestBody Student stud) {
		return studentDao.save(stud);  // JSON object
	}

	@GetMapping("/students/{studID}")
	public Student getStudentbyId(@PathVariable("studID") int studID) {
		return studentDao.getStudentById(studID);
	}
	
	@GetMapping("/students")
	public List<Student> getStudents(){
		return studentDao.getAllStudents();
	}
	
	@PutMapping("/students")
	public Student updateStudent(@RequestBody Student stud) {
		return studentDao.update(stud);
	}
	
	@DeleteMapping("/students/{studID}")
	public String deleteStudentById(@PathVariable("studID") int studID) {
		studentDao.delete(studID);
		return "Studnt with ID: "+studID+" is deleted successfully";
	}
}
