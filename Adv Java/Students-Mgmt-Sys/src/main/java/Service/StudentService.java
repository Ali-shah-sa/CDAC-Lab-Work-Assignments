package Service;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import Entity.Student;
import Repository.StudentRepository;

@Service
public class StudentService {

    @Autowired
    private StudentRepository repo;
	public Object createStudent;

    public Student save(Student student) {
        return repo.save(student);
    }

    public List<Student> getAll() {
        return repo.findAll();
    }

    public Student getById(Long id) {
        return repo.findById(id).orElseThrow();
    }

    public Student update(Long id, Student newStudent) {
        Student s = getById(id);
        s.setName(newStudent.getName());
        s.setEmail(newStudent.getEmail());
        s.setCourse(newStudent.getCourse());
        s.setEnrollmentDate(newStudent.getEnrollmentDate());
        return repo.save(s);
    }

    public void delete(Long id) {
        repo.deleteById(id);
    }

    public List<Student> getByCourse(String course) {
        return repo.findByCourse(course);
    }

    public List<Student> searchByName(String name) {
        return repo.findByNameContainingIgnoreCase(name);
    }

	public Object createStudent(Student student) {
		// TODO Auto-generated method stub
		return null;
	}

	public List<Student> getAllStudents() {
		// TODO Auto-generated method stub
		return null;
	}

	public Student getStudentById(Long id) {
		// TODO Auto-generated method stub
		return null;
	}

	public Student updateStudent(Long id, Student student) {
		// TODO Auto-generated method stub
		return null;
	}

	public void deleteStudent(Long id) {
		// TODO Auto-generated method stub
		
	}

	public List<Student> getStudentsByCourse(String course) {
		// TODO Auto-generated method stub
		return null;
	}

	public List<Student> searchStudentsByName(String name) {
		// TODO Auto-generated method stub
		return null;
	}
}
