﻿CREATE TABLE IF NOT EXISTS profiles
(
	pk_profile_id int unsigned NOT NULL AUTO_INCREMENT,
	fk_user_id varchar(700) NOT NULL,
	fk_campus_id int(11) unsigned DEFAULT NULL,

	first_name varchar(100) DEFAULT NULL,
	last_name varchar(100) DEFAULT NULL,

	PRIMARY KEY (pk_profile_id),
	KEY profile_user (fk_user_id),

	KEY profile_campus (fk_campus_id),

	CONSTRAINT profile_user FOREIGN KEY (fk_user_id) REFERENCES dssdata_auth.users (Id),

	CONSTRAINT profile_campus FOREIGN KEY (fk_campus_id) REFERENCES campuses (pk_campus_id)

) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=latin1;
