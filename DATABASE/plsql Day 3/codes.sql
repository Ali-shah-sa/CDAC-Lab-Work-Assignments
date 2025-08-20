-- 1. List all students with their enrolled course names
DELIMITER //
CREATE PROCEDURE get_students_courses()
BEGIN
    DECLARE done INT DEFAULT 0;
    DECLARE sid INT;
    DECLARE cname VARCHAR(100);
    DECLARE result_cursor CURSOR FOR
        SELECT e.student_id, c.course_name
        FROM enrollments e
        JOIN courses c ON e.course_id = c.course_id;
    DECLARE CONTINUE HANDLER FOR NOT FOUND SET done = 1;

    CREATE TEMPORARY TABLE temp_students_courses (info VARCHAR(255));
    OPEN result_cursor;
    read_loop: LOOP
        FETCH result_cursor INTO sid, cname;
        IF done THEN
            LEAVE read_loop;
        END IF;
        INSERT INTO temp_students_courses (info) VALUES (CONCAT('Student ID:', sid, ' - Course:', cname));
    END LOOP;
    CLOSE result_cursor;

    SELECT * FROM temp_students_courses;
    DROP TEMPORARY TABLE temp_students_courses;
END //
DELIMITER ;

-- 2. Display marks for each student-course pair
DELIMITER //
CREATE PROCEDURE show_student_marks()
BEGIN
    DECLARE done INT DEFAULT 0;
    DECLARE sid INT;
    DECLARE cid INT;
    DECLARE marks INT;
    DECLARE result_cursor CURSOR FOR
        SELECT student_id, course_id, marks_obtained FROM marks;
    DECLARE CONTINUE HANDLER FOR NOT FOUND SET done = 1;

    CREATE TEMPORARY TABLE temp_marks (mark_info VARCHAR(255));
    OPEN result_cursor;
    loop_marks: LOOP
        FETCH result_cursor INTO sid, cid, marks;
        IF done THEN
            LEAVE loop_marks;
        END IF;
        INSERT INTO temp_marks (mark_info) VALUES (CONCAT('Student:', sid, ', Course:', cid, ', Marks:', marks));
    END LOOP;
    CLOSE result_cursor;

    SELECT * FROM temp_marks;
    DROP TEMPORARY TABLE temp_marks;
END //
DELIMITER ;

DELIMITER $$

CREATE PROCEDURE GetAttendanceByStudent(IN p_student_id INT)
BEGIN
    -- Declare necessary variables and handlers
    DECLARE done INT DEFAULT 0;
    DECLARE attendance_date DATE;
    DECLARE attendance_status ENUM('Present', 'Absent') DEFAULT 'Absent';
    
    -- Declare the cursor
    DECLARE attendance_cursor CURSOR FOR
        SELECT date, status
        FROM attendance
        WHERE student_id = p_student_id;
    
    -- Declare handler to set 'done' flag when no more rows are fetched
    DECLARE CONTINUE HANDLER FOR NOT FOUND SET done = 1;
    
    -- Create temporary table to store the attendance data
    CREATE TEMPORARY TABLE temp_attendance (
        attendance_date DATE,
        attendance_status ENUM('Present', 'Absent')
    );
    
    -- Open the cursor
    OPEN attendance_cursor;
    
    -- Loop through the cursor and insert fetched rows into the temporary table
    read_loop: LOOP
        FETCH attendance_cursor INTO attendance_date, attendance_status;
        
        IF done THEN
            LEAVE read_loop;
        END IF;
        
        -- Insert the fetched data into the temporary table
        INSERT INTO temp_attendance (attendance_date, attendance_status)
        VALUES (attendance_date, attendance_status);
    END LOOP;
    
    -- Close the cursor
    CLOSE attendance_cursor;
    
    -- Select all rows from the temporary table to return the result
    SELECT * FROM temp_attendance;
    
    -- Drop the temporary table after use
    DROP TEMPORARY TABLE temp_attendance;
END $$

DELIMITER ;

DELIMITER $$

CREATE PROCEDURE get_enrolled_students_by_department2(IN dept_name VARCHAR(50))
BEGIN
    DECLARE done INT DEFAULT FALSE;
    DECLARE s_id INT;
    DECLARE s_name VARCHAR(100);

    -- Cursor for students in the given department who are enrolled in at least one course
    DECLARE cur CURSOR FOR
        SELECT DISTINCT s.student_id, s.name
        FROM students s
        JOIN enrollments e ON s.student_id = e.student_id
        WHERE s.department = dept_name;

    DECLARE CONTINUE HANDLER FOR NOT FOUND SET done = TRUE;

    -- Open cursor
    OPEN cur;

    read_loop: LOOP
        FETCH cur INTO s_id, s_name;
        IF done THEN
            LEAVE read_loop;
        END IF;

        -- Output the student ID and name
        SELECT CONCAT('Student ID: ', s_id, ', Name: ', s_name) AS student_info;
    END LOOP;

    -- Close cursor
    CLOSE cur;
END$$

DELIMITER ;


-- 5. Display course names offered by a department
DELIMITER //
CREATE PROCEDURE get_courses_by_department(IN dept VARCHAR(50))
BEGIN
    DECLARE done INT DEFAULT 0;
    DECLARE cname VARCHAR(100);
    DECLARE result_cursor CURSOR FOR
        SELECT course_name FROM courses WHERE department = dept;
    DECLARE CONTINUE HANDLER FOR NOT FOUND SET done = 1;

    CREATE TEMPORARY TABLE temp_courses (course_name VARCHAR(100));
    OPEN result_cursor;
    c_loop: LOOP
        FETCH result_cursor INTO cname;
        IF done THEN
            LEAVE c_loop;
        END IF;
        INSERT INTO temp_courses (course_name) VALUES (cname);
    END LOOP;
    CLOSE result_cursor;

    SELECT * FROM temp_courses;
    DROP TEMPORARY TABLE temp_courses;
END //
DELIMITER ;

-- 6. Show students with more than one course enrollment
DELIMITER //
CREATE PROCEDURE students_multiple_courses()
BEGIN
    DECLARE done INT DEFAULT 0;
    DECLARE sid INT;
    DECLARE cnt INT;
    DECLARE result_cursor CURSOR FOR
        SELECT student_id, COUNT(*) as course_count
        FROM enrollments GROUP BY student_id HAVING COUNT(*) > 1;
    DECLARE CONTINUE HANDLER FOR NOT FOUND SET done = 1;

    CREATE TEMPORARY TABLE temp_multi_courses (info VARCHAR(255));
    OPEN result_cursor;
    loop_multi: LOOP
        FETCH result_cursor INTO sid, cnt;
        IF done THEN
            LEAVE loop_multi;
        END IF;
        INSERT INTO temp_multi_courses (info) VALUES (CONCAT('Student ID:', sid, ' has enrolled in ', cnt, ' courses'));
    END LOOP;
    CLOSE result_cursor;

    SELECT * FROM temp_multi_courses;
    DROP TEMPORARY TABLE temp_multi_courses;
END //
DELIMITER ;

-- 7. List students and their departments
DELIMITER $$

CREATE PROCEDURE list_students_with_departments()
BEGIN
    DECLARE done INT DEFAULT 0;
    DECLARE s_id INT;
    DECLARE s_name VARCHAR(100);
    DECLARE s_dept VARCHAR(50);

    -- Declare cursor for student list
    DECLARE cur CURSOR FOR 
        SELECT student_id, name, department FROM students;

    -- Declare CONTINUE HANDLER to exit loop when no more rows
    DECLARE CONTINUE HANDLER FOR NOT FOUND SET done = 1;

    -- Open cursor
    OPEN cur;

    student_loop: LOOP
        FETCH cur INTO s_id, s_name, s_dept;
        
        IF done THEN
            LEAVE student_loop;
        END IF;

        -- Output each row (replace SELECT with INSERT if you want to store it)
        SELECT CONCAT('Student ID: ', s_id, ', Name: ', s_name, ', Department: ', s_dept) AS student_info;

    END LOOP;

    -- Close cursor
    CLOSE cur;
END$$

DELIMITER ;

-- 8. View grades table entries (if any)
DELIMITER //
CREATE PROCEDURE view_grades()
BEGIN
    DECLARE done INT DEFAULT 0;
    DECLARE sid INT;
    DECLARE cid INT;
    DECLARE g VARCHAR(25);
    DECLARE result_cursor CURSOR FOR
        SELECT student_id, course_id, grade FROM grades;
    DECLARE CONTINUE HANDLER FOR NOT FOUND SET done = 1;

    CREATE TEMPORARY TABLE temp_grades (grade_info VARCHAR(255));
    OPEN result_cursor;
    loop_grades: LOOP
        FETCH result_cursor INTO sid, cid, g;
        IF done THEN
            LEAVE loop_grades;
        END IF;
        INSERT INTO temp_grades (grade_info) VALUES (CONCAT('Student:', sid, ', Course:', cid, ', Grade:', g));
    END LOOP;
    CLOSE result_cursor;

    SELECT * FROM temp_grades;
    DROP TEMPORARY TABLE temp_grades;
END //
DELIMITER ;

-- 9. Display student names and admission year who joined after 2021
DELIMITER //
CREATE PROCEDURE students_after_2021()
BEGIN
    DECLARE done INT DEFAULT 0;
    DECLARE sname VARCHAR(100);
    DECLARE year INT;
    DECLARE result_cursor CURSOR FOR
        SELECT name, admission_year FROM students WHERE admission_year > 2021;
    DECLARE CONTINUE HANDLER FOR NOT FOUND SET done = 1;

    CREATE TEMPORARY TABLE temp_year_students (info VARCHAR(255));
    OPEN result_cursor;
    year_loop: LOOP
        FETCH result_cursor INTO sname, year;
        IF done THEN
            LEAVE year_loop;
        END IF;
        INSERT INTO temp_year_students (info) VALUES (CONCAT(sname, ' - ', year));
    END LOOP;
    CLOSE result_cursor;

    SELECT * FROM temp_year_students;
    DROP TEMPORARY TABLE temp_year_students;
END //
DELIMITER ;

-- 10. Boost low marks (marks < 50)
DELIMITER $$

CREATE PROCEDURE boost_low_marks()
BEGIN
  DECLARE done INT DEFAULT FALSE;
  DECLARE sid INT;
  DECLARE cid INT;
  DECLARE mark INT;

  -- Writable cursor: locks rows in `marks` table
  DECLARE cur CURSOR FOR
    SELECT student_id, course_id, marks_obtained FROM marks WHERE marks_obtained < 50 FOR UPDATE;

  DECLARE CONTINUE HANDLER FOR NOT FOUND SET done = TRUE;

  OPEN cur;
  read_loop: LOOP
    FETCH cur INTO sid, cid, mark;
    IF done THEN LEAVE read_loop; END IF;

    -- Update same row the cursor selected (this is allowed)
    UPDATE marks
    SET marks_obtained = mark + 5
    WHERE student_id = sid AND course_id = cid;
  END LOOP;
  CLOSE cur;
END$$

DELIMITER ;
