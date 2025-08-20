package Controller;

import java.util.List;
import Service.StudentService;


import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;

import Entity.Student;
import Service.StudentService;

@RestController
@RequestMapping("/api/students")
public class StudentController {

    @Autowired
    private StudentService service;

    @Autowired
    private StudentService studentService;

    
    @PostMapping
    public ResponseEntity<Object> addStudent(@RequestBody Student student) {
        return ResponseEntity.status(HttpStatus.CREATED).body(studentService.createStudent(student));
    }

    @GetMapping
    public List<Student> getAllStudents() {
        return service.getAllStudents();
    }

    @GetMapping("/{id}")
    public Student getStudentById(@PathVariable Long id) {
        return service.getStudentById(id);
    }

    @PutMapping("/{id}")
    public Student updateStudent(@PathVariable Long id, @RequestBody Student student) {
        return service.updateStudent(id, student);
    }

    @DeleteMapping("/{id}")
    public ResponseEntity<Void> deleteStudent(@PathVariable Long id) {
        service.deleteStudent(id);
        return ResponseEntity.noContent().build();
    }

    @GetMapping("/course/{course}")
    public List<Student> getStudentsByCourse(@PathVariable String course) {
        return service.getStudentsByCourse(course);
    }

    @GetMapping("/search")
    public List<Student> searchStudents(@RequestParam String name) {
        return service.searchStudentsByName(name);
    }
}
