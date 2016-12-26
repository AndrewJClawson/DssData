CREATE TABLE IF NOT EXISTS _enrollment_statuses
(
	pk_enrollment_status_id int(11) unsigned NOT NULL AUTO_INCREMENT,
	name varchar(20) DEFAULT NULL,
	
	PRIMARY KEY (pk_enrollment_status_id)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=latin1;