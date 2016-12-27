CREATE TABLE IF NOT EXISTS _assessment_titles
(
	pk_assessment_title_id int(11) unsigned NOT NULL AUTO_INCREMENT,
	name varchar(50) DEFAULT NULL,
	
	PRIMARY KEY (pk_assessment_title_id)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=latin1;