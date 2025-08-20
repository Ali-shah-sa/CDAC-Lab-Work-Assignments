package com.example.spring.dao;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Repository;

import com.example.spring.entity.Student;

import jakarta.persistence.EntityManager;
import jakarta.persistence.TypedQuery;
import jakarta.transaction.Transactional;

@Repository
public class StudentDaoImpl implements StudentDao{

	@Autowired  // Inject the instance / object
	private EntityManager entityManager;
	
	@Override
	@Transactional   // atomocity => ACID => database
	public Student save(Student student) {
		entityManager.persist(student);  // store / save / create in database
		return student;
	}

	@Override
	public Student getStudentById(int id) { // primary key of table student
		return entityManager.find(Student.class, id);
	}

	@Override
	public List<Student> getAllStudents() {
		TypedQuery<Student> query = entityManager.createQuery("from Student", Student.class);
		return query.getResultList(); // all students => table => object
	}

	@Override
	@Transactional
	public Student update(Student student) {
		entityManager.merge(student);
		return student;
	}

	@Override
	@Transactional
	public void delete(int id) {
		Student stud = entityManager.find(Student.class, id);
		entityManager.remove(stud);
	}

}
