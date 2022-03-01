CREATE DATABASE livraria1;
USE livraria1;

CREATE TABLE autor(
	id INT AUTO_INCREMENT,
    nome VARCHAR(100),
    nacionalidade VARCHAR(100),
    PRIMARY KEY (id)
);
CREATE TABLE editora(
	id INT AUTO_INCREMENT,
	nome VARCHAR(100),
	PRIMARY KEY (id)
);

CREATE TABLE usuario(
	id INT AUTO_INCREMENT,
	nome VARCHAR(100),
	DT_NASCIMENTO date,
	PRIMARY KEY (id)
); 

CREATE TABLE emprestimo(
	id INT AUTO_INCREMENT,
    id_usuario INT,
    dt_emprestimo DATE,
    dt_devolucao DATE,
    PRIMARY KEY(id),
    FOREIGN KEY(id_usuario) REFERENCES usuario(id_usuario)
);

CREATE TABLE livro(
	id INT AUTO_INCREMENT,
    titulo VARCHAR(100),
    ano INT,
    exemplares INT,
    id_autor INT,
    id_editora INT,
    PRIMARY KEY (ID),
    FOREIGN KEY (id_autor) REFERENCES autor(id_autor),
    FOREIGN KEY (id_editora) REFERENCES editora(id_editora)
);
CREATE TABLE item_emprestimo(
	id_emprestimo INT,
	id_livro INT,
	foreign key (id_emprestimo) REFERENCES emprestimo(id_emprestimo),
	foreign key (id_livro) REFERENCES livro(id_livro)
);
