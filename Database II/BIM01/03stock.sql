DROP DATABASE estoque;
CREATE DATABASE estoque;
USE estoque;

CREATE TABLE categoria(
	cd_categoria INT PRIMARY KEY AUTO_INCREMENT,
	nome VARCHAR(45)
);

CREATE TABLE cliente(
	cd_cliente INT PRIMARY KEY AUTO_INCREMENT,
    nm_cliente VARCHAR(45),
    ds_email_cliente VARCHAR(80),
    ds_tel_cliente VARCHAR(45)
);

CREATE TABLE pedido(
	cd_pedido INT PRIMARY KEY AUTO_INCREMENT,
    dt_pedido VARCHAR(45),
    id_cliente INT,
    vl_total_pedido DECIMAL(10,2),
    FOREIGN KEY (id_cliente) REFERENCES cliente(cd_cliente)
);

CREATE TABLE produto(
	cd_produto INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(50),
    qt_produto VARCHAR(45),
    vl_produto DECIMAL(10,2),
    id_categoria INT,
    FOREIGN KEY (id_categoria) REFERENCES categoria(cd_categoria)
);

CREATE TABLE produto_pedido(
	id_pedido INT,
    id_produto INT,
    qt_produto_pedido INT,
    vl_unitario DECIMAL(10,2),
    FOREIGN KEY (id_pedido) REFERENCES pedido (id_pedido),
    FOREIGN KEY (id_produto) REFERENCES cd_categoriaproduto (id_produto)
);

INSERT INTO categoria (nome) VALUES("Laticinios");
INSERT INTO categoria (nome) VALUES("Padaria");
INSERT INTO categoria (nome) VALUES("Grãos");

INSERT INTO produto(nome, qt_produto, vl_produto, id_categoria) VALUES ("Leite", 10, 10.25, 1);
INSERT INTO produto(nome, qt_produto, vl_produto, id_categoria) VALUES ("Iorgute", 10, 2, 1);
INSERT INTO produto(nome, qt_produto, vl_produto, id_categoria) VALUES ("Queijo Fresco", 20, 20, 1);

INSERT INTO produto(nome, qt_produto, vl_produto, id_categoria) VALUES ("Pão", 10, 10.25, 2);
INSERT INTO produto(nome, qt_produto, vl_produto, id_categoria) VALUES ("Rosca doce", 10, 2, 2);
INSERT INTO produto(nome, qt_produto, vl_produto, id_categoria) VALUES ("Pão de queijo", 10, 5.25, 2);

INSERT INTO produto(nome, qt_produto, vl_produto, id_categoria) VALUES ("Arroz", 10, 5.25, 3);
INSERT INTO produto(nome, qt_produto, vl_produto, id_categoria) VALUES ("Feijão", 10, 5.25, 3);
INSERT INTO produto(nome, qt_produto, vl_produto, id_categoria) VALUES ("Lentilha", 10, 5.25, 3);


INSERT INTO cliente(nm_cliente, ds_email_cliente, ds_tel_cliente) VALUES ("Luca Poe", "lukinhaMilGrau@gmail.com", "130928922");
INSERT INTO cliente(nm_cliente, ds_email_cliente, ds_tel_cliente) VALUES ("Rodolfo", "primocena@profrodolfo.com.br", "130935722");
INSERT INTO cliente(nm_cliente, ds_email_cliente, ds_tel_cliente) VALUES ("Fidélis", "amo@liberalismo.com", "13092491");
