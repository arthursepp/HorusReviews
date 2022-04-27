CREATE DATABASE HorusRev

USE HorusRev

CREATE TABLE Usur(

	CodUser		INT			NOT NULL IDENTITY (1,1),
	UserName	VARCHAR(15) NOT NULL,
	CONSTRAINT	PK_UserName PRIMARY KEY(UserName),
	Nome		VARCHAR(50)	NOT NULL,
	DataNasc	DATE		NOT NULL,
	Email		VARCHAR(55) NOT NULL,
	Senha		VARCHAR(12) NOT NULL

)
INSERT INTO Conteudo 
VALUES ('Eternos', 'De Chloé Zhao', '04 de Novembro de 2021', 'Originários dos primeiros seres a terem habitado a Terra, Os Eternos fazem parte de uma raça modificada geneticamente pelos deuses espaciais conhecidos como Celestiais. Dotados de características como imortalidade e manipulação de energia cósmica, eles são frutos de experiências fracassadas de seus próprios criadores, que também foram responsáveis por gerar os Deviantes, seus principais inimigos.', 'Ação - Ficção Científica - Fantasia')
INSERT INTO Conteudo
VALUES ('Duna', 'De Denis Villeneuve', '21 de Outubro de 2021','Inspirado na série de livros de Frank Herbert, Duna se passa em um futuro longínquo. O Duque Leto Atreides administra o planeta desértico Arrakis, também conhecido como Duna, lugar de única fonte da substância rara chamada de "melange", usada para estender a vida humana, chegar a velocidade da luz e garantir poderes sobrehumanos. Para isso ele manda seu filho, Paul Atreides (Timothée Chalamet), um jovem brilhante e talentoso que nasceu para ter um grande destino além de sua imaginação, e seus servos e concubina Lady Jessica (Rebecca Fergunson), que também é uma Bene Gesserit. Eles vão para Duna, afim de garantir o futuro de sua família e seu povo. Porém, uma traição amarga pela posse da melange faz com que Paul e Jessica fujam para os Fremen, nativos do planeta que vivem nos cantos mais longes do deserto.', 'Ficção científica - Drama')
INSERT INTO Conteudo
VALUES ('Finch', 'De Miguel Sapochnik', '5 de Novembro de 2021', 'Eu um mundo pós-apocalíptico, um robô construído para proteger o cachorro do seu criado, que está a beira da morte, aprende sobre a vida, amor e amizade, aprendendo o que significa ser humano.', 'Ficção Científica - Drama')
INSERT INTO Conteudo
VALUES ('Cowboy Bebop', 'De André Nemec, Jeff Pinkner', '19 de Novembro de 2021','Baseado no anime dos anos 1990, Cowboy Bebop acompanha Spike Spiegel (John Cho), Jet Black (Mustafa Shakir) e Faye Valentine (Daniella Pineda) enquanto eles formam um poderoso grupo de caçadores de recompensas se aventurando pelo sistema solar atrás dos criminosos mais perigosos do universo, como Vicious (Alex Hassell). Juntos, eles embarcaram em diversas aventuras mortais pela galáxia, encontrando todo tipo de figura e formando aliados e inimigos pelo caminho.', 'Aventura - Ficção Científica - Animes - Ação')
INSERT INTO Conteudo
VALUES ('Resident Evil: Bem-Vindo a Raccoon City', 'De Johannes Roberts', '2 de Dezembro de 2021', 'Passando no ano de 1998, Resident Evil: Bem-Vindo a Raccoon City é o filme que explica os segredos da Mansão Spencer e da cidade de Raccoon City.', 'Ação - Terror')

CREATE TABLE Conteudo(

	ContCod		INT			NOT NULL IDENTITY(1,1),
	CONSTRAINT	PK_ContCod	PRIMARY KEY(ContCod),
	ContName	VARCHAR(100)NOT NULL,
	Diretor		VARCHAR(70) NOT NULL,
	DataLanc	CHAR(30)	NOT NULL,
	Sinopse		VARCHAR(1000)NOT NULL,
	Categoria	VARCHAR(50)	NOT NULL
)


CREATE TABLE Coment(

	UserNameComent		VARCHAR(15) NOT NULL,
	CONSTRAINT			FK_UserName FOREIGN KEY(UserNameComent) REFERENCES Usur(UserName),
	CodComent			INT			NOT NULL,
	CONSTRAINT			PK_CodComent	PRIMARY KEY(CodComent),
	DataPost			DATE		NOT NULL

)
SELECT * FROM Conteudo
SELECT * FROM Usur 
SELECT * FROM Coment




DROP TABLE Usur
DROP TABLE Coment
DROP TABLE Conteudo

DELETE FROM Conteudo
DELETE FROM Usur
