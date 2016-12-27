CREATE TABLE IF NOT EXISTS forms
(
	pk_form_id int(11) unsigned NOT NULL AUTO_INCREMENT,
	fk_form_label_id int(11) unsigned NOT NULL,
	fk_student_id int(11) unsigned NOT NULL,
	fk_quarter_id int(11) unsigned NOT NULL,
	
	PRIMARY KEY (pk_form_id),
	KEY label (fk_form_label_id),
	KEY student (fk_student_id),
	KEY quarter (fk_quarter_id),
	CONSTRAINT label FOREIGN KEY (fk_form_label_id) REFERENCES _form_label (pk_form_label_id),
	CONSTRAINT student FOREIGN KEY (fk_student_id) REFERENCES students (pk_student_id),
	CONSTRAINT quarter FOREIGN KEY (fk_quarter_id) REFERENCES quarters (pk_quarter_id)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=latin1;