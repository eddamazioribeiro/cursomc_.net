-- Categoria
CREATE TABLE categoria(
id		INT PRIMARY KEY,
nome	VARCHAR(25)
);


-- Produto
CREATE TABLE produto(
id		INT PRIMARY KEY,
nome	VARCHAR(50),
preco	DECIMAL(11,2),
desconto	DECIMAL(5,2)
);

-- Produto-Categoria
CREATE TABLE prod_categ(
id_produto		INT, 
id_categoria	INT

PRIMARY KEY(id_produto, id_categoria),
FOREIGN KEY(id_produto) REFERENCES produto(id),
FOREIGN KEY(id_categoria) REFERENCES categoria(id)
);

-- Estado
CREATE TABLE estado(
id		INT PRIMARY KEY,
nome	VARCHAR(50),
sigla	VARCHAR(2) NOT NULL
);

-- Cidade
CREATE TABLE cidade(
id		INT PRIMARY KEY,
nome	VARCHAR(50),
id_estado	INT

FOREIGN KEY(id_estado) REFERENCES estado(id)
);

DROP TABLE endereco;

-- Endereço
CREATE TABLE endereco(
id			INT,
id_cliente	INT,
logradouro	VARCHAR(70) NOT NULL,
numero	INT NOT NULL,
complemento	VARCHAR(70),
bairro	VARCHAR(50) NOT NULL,
cep		INT NOT NULL,
id_cidade	INT NOT NULL

PRIMARY KEY(id, id_cliente),
FOREIGN KEY(id_cidade) REFERENCES cidade(id),
FOREIGN KEY(id_cliente) REFERENCES cliente(id)
);

ALTER TABLE endereco ADD FOREIGN KEY(id_cliente) REFERENCES cliente(id);

-- Cliente
CREATE TABLE cliente(
id		INT PRIMARY KEY,
nome	VARCHAR(70) NOT NULL,
cpf_cnpj	VARCHAR(11),
tipo	VARCHAR(1)
);

-- Contato
CREATE TABLE contato(
id		INT,
id_cliente	INT NOT NULL,
tipo	VARCHAR(1) NOT NULL,
dados	VARCHAR(50) NOT NULL

PRIMARY KEY(id, id_cliente),
FOREIGN KEY(id_cliente) REFERENCES cliente(id)
);

-- Pagamento
CREATE TABLE pagamento(
id			INT PRIMARY KEY,
estado		VARCHAR(1) NOT NULL,
dtavencimento	DATE,
dtapagamento	DATE,
qtd_parcela		INT
);

-- Pedido
CREATE TABLE pedido(
id			INT NOT NULL UNIQUE,
id_cliente	INT,
dtahorpedido	DATETIME

PRIMARY KEY(id, id_cliente),
FOREIGN KEY(id_cliente) REFERENCES cliente(id)
);

-- Pedido-Pagamento
CREATE TABLE ped_pagto(
id_pedido		INT,
id_pagamento	INT

PRIMARY KEY(id_pedido, id_pagamento),
FOREIGN KEY(id_pedido) REFERENCES pedido(id),
FOREIGN KEY(id_pagamento) REFERENCES pagamento(id)
);

-- Itens Pedido
CREATE TABLE pedido_item(
id_pedido		INT,
id_produto		INT,
quantidade		INT NOT NULL,
preco			DECIMAL(11,2),
desconto		DECIMAL(5,2)

PRIMARY KEY(id_pedido, id_produto),
FOREIGN KEY(id_pedido) REFERENCES pedido(id),
FOREIGN KEY(id_produto) REFERENCES produto(id)
);