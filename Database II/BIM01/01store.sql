CREATE TABLE cliente(
	cd_cliente INT NOT NULL,
    ic_tipo_cliente_pf_pj CHAR(3),
    nm_cliente VARCHAR(255),
    rg_cliente VARCHAR(45),
    cpf_cliente VARCHAR(45),
    cd_telefone_cliente VARCHAR(45),
    cnpj_cliente VARCHAR(45),
    ie_cliente VARCHAR(45),
    ds_endereco_cliente VARCHAR(100),
    cd_cep_cliente VARCHAR(12),
    id_cidade INT,
    PRIMARY KEY(cd_cliente),
    FOREIGN KEY (id_cidade) REFERENCES cidade(id_cidade)
);

CREATE TABLE venda(
	cd_venda INT NOT NULL,
    dt_venda DATE,
    vl_total_venda DECIMAL,
    id_cliente INT,
    PRIMARY KEY (cd_venda),
    FOREIGN KEY (id_cliente) REFERENCES cliente(id_cliente)
);

CREATE TABLE produto_item_venda(
	id_produto INT,
    id_venda INT,
    qt_produto DECIMAL,
    vl_unitario_produto VARCHAR(45),
    FOREIGN KEY (id_produto) REFERENCES produto(id_produto),
    FOREIGN KEY (id_venda) REFERENCES venda(id_venda)
);

CREATE TABLE produto(
	cd_produto INT NOT NULL,
    nm_produto VARCHAR(255),
    qt_total INT,
    vl_produto DECIMAL,
    PRIMARY KEY (cd_produto)
);

CREATE TABLE servico_item_venda(
	id_venda INT,
    id_servico INT,
    qt_servico DECIMAL,
    vl_unitario_servico DECIMAL,
    FOREIGN KEY (id_venda) REFERENCES venda(id_venda),
    FOREIGN KEY (id_servico) REFERENCES servico(id_servico)
);

CREATE TABLE servico(
	cd_servico INT NOT NULL,
    nm_servico VARCHAR(255),
    ds_servico LONGTEXT,
    vl_servico DECIMAL,
    PRIMARY KEY (cd_servico)
);

CREATE TABLE cidade(
  cd_cidade INT NOT NULL,
  nm_cidade VARCHAR(45),
  id_estado INT,
  PRIMARY KEY(cd_cidade),
  FOREIGN KEY (id_estado) REFERENCES estado(id_estado)
);

CREATE TABLE estado(
	cd_estado INT NOT NULL,
    nm_estado VARCHAR(120),
    uf_estado CHAR(2),
    PRIMARY KEY (cd_estado)
);