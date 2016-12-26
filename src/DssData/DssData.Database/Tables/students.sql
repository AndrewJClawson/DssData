CREATE TABLE IF NOT EXISTS students
(
	pk_student_id int(11) unsigned NOT NULL AUTO_INCREMENT,
	fk_campus_id int(11) unsigned NULL,

	fk_enrollment_status_id int(11) unsigned NULL,
	first_name varchar(100),
	last_name varchar(100),

	address varchar(100),
	city varchar(100),
	state varchar(100),
	zip varchar(100),

	phone_number varchar(12),
	PRIMARY KEY (pk_student_id),
	KEY campus (fk_campus_id),
	KEY enrollment_status (fk_enrollment_status_id),
	CONSTRAINT campus FOREIGN KEY (fk_campus_id) REFERENCES campuses (pk_campus_id),
	CONSTRAINT enrollment_status FOREIGN KEY (fk_enrollment_status_id) REFERENCES _enrollment_status (pk_enrollment_status_id)
	
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=latin1;