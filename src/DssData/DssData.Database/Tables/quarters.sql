CREATE TABLE IF NOT EXISTS quarters
(
	pk_quarter_id int(11) unsigned NOT NULL AUTO_INCREMENT,
	fk_school_year_id int(11) unsigned NOT NULL,
	number int(1) DEFAULT NULL,
	
	PRIMARY KEY (pk_quarter_id),
	KEY school_year (fk_school_year_id),
	CONSTRAINT school_year FOREIGN KEY (fk_school_year_id) REFERENCES school_years (pk_school_year_id)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=latin1;