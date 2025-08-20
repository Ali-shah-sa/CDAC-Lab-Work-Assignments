package Entity;

import java.time.LocalDate;

import org.springframework.data.annotation.Id;

import com.fasterxml.jackson.annotation.JsonFormat;

import jakarta.persistence.Entity;
import jakarta.persistence.GeneratedValue;
import jakarta.persistence.GenerationType;

@Entity
public class Student {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;

    private String name;
    private String email;
    private String course;

    @JsonFormat(pattern = "yyyy-MM-dd")
    private LocalDate enrollmentDate;

	public Object getName() {
		// TODO Auto-generated method stub
		return null;
	}

	public Object getEmail() {
		// TODO Auto-generated method stub
		return null;
	}

	public Object getCourse() {
		// TODO Auto-generated method stub
		return null;
	}

	public Object getEnrollmentDate() {
		// TODO Auto-generated method stub
		return null;
	}

	public void setName(Object name2) {
		// TODO Auto-generated method stub
		
	}

	public void setEmail(Object email2) {
		// TODO Auto-generated method stub
		
	}

	public void setCourse(Object course2) {
		// TODO Auto-generated method stub
		
	}

	public void setEnrollmentDate(Object enrollmentDate2) {
		// TODO Auto-generated method stub
		
	}

	public Object createStudent(Student student) {
		// TODO Auto-generated method stub
		return null;
	}

    // Getters and setters
}
