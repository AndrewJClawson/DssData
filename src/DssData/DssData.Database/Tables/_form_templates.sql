CREATE TABLE IF NOT EXISTS _form_templates
(
	pk_form_template_id int(11) unsigned NOT NULL AUTO_INCREMENT,
	name varchar(20) DEFAULT NULL,
	
	PRIMARY KEY (pk_form_template_id)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=latin1;