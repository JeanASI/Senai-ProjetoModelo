CREATE TABLE naturalidade (
 id int auto_increment not null,
 descricao  VARCHAR(100) not null,
 dataCriacao datetime not null,
 dataAlteracao datetime not null,
 ativo boolean not null,
 constraint pk_naturalidade_id primary key (id)
);