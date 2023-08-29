create database calculoIMC;
use calculoIMC;

create table paciente(
id_paciente int not null auto_increment,
nome_paciente varchar(50),
altura_paciente double(10,2),
peso_paciente double(10,3),
situacao_paciente varchar (50),
imc_paciente double(10,3),
data_consulta date,
primary key(id_paciente)
);

select * from paciente