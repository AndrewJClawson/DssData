CREATE TABLE IF NOT EXISTS school_years
(
	pk_school_year_id int(11) unsigned NOT NULL AUTO_INCREMENT,
	name varchar(20) DEFAULT NULL,
	
	PRIMARY KEY (pk_school_year_id)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=latin1;