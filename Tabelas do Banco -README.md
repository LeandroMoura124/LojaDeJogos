# LojaDeJogos
Projeto escolar Etec Professor Basilides de Godoy. Desenvolvimento de um aplicativo web C#, Asp.net e MVC. Cadastro de jogos funcionários e clientes

-- Tabelas criadas no MySql(Banco De Dados)





create database db_Loja
default character set utf8 
default collate utf8_general_ci; 


create table jogos(
IDjogos int primary key auto_increment,
nomeJogo varchar(40)not null unique,
versao int not null,
desenvolvedor varchar(20) not null, 
genero varchar(20) not null,
faixaet int not null,
plataforma varchar(80) not null, 
AnoLanc year not null,
sinopse mediumtext not null

) DEFAULT CHARSET = utf8;





create table cliente(
nomeCliente varchar(40) not null,
cpf bigint(14) not null,
nascimento date not null,
email varchar(40) not null,
cel varchar(11) not null,
enderecocli varchar(100) not null,
primary key(cpf)

)DEFAULT CHARSET = utf8;


create table funcionario(
IDfunc int not null,
nomeFunc varchar(40) not null,
cpf bigint(14) not null,
rg bigint(14) not null,
nascimento date not null,
endereco varchar(100) not null,
cel varchar(11) not null,
email varchar(40) not null, 
cargo varchar(30) not null,
Primary key (IDfunc, cpf)

) DEFAULT CHARSET = utf8;

        select * from jogos;

select IDfunc, nomeFunc, cpf, endereco, cel, email, cargo from funcionario;

select * from cliente;
select * from funcionario;
select * from jogos;





/*
alter table endereco add constraint FK_endereco_funcionario
foreign key(IDendereco) references funcionario(IDfunc);
alter table endereco add constraint FK_endereco_cliente
foreign key(IDendereco) references cliente(IDcliente);*/
