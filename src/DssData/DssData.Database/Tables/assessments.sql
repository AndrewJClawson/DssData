CREATE TABLE IF NOT EXISTS assessments
(
	pk_assessment_id int(11) unsigned NOT NULL AUTO_INCREMENT,
	fk_form_id int(11) unsigned NOT NULL,
	fk_assessment_title_id int(11) unsigned NOT NULL,


	PRIMARY KEY (pk_assessment_id),
	KEY form (fk_form_id),
	KEY assessment_title (fk_assessment_title_id),

	CONSTRAINT form FOREIGN KEY (fk_form_id) REFERENCES form (pk_form_id),
	CONSTRAINT assessment_title FOREIGN KEY (fk_assessment_title_id) REFERENCES _assessment_titles (pk_assessment_title_id)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=latin1;