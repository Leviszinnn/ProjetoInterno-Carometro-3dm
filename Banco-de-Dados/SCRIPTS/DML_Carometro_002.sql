USE DM_CAROMETRO;
GO

INSERT INTO escola (nomeEscola, endereco, numero)
VALUES ('SESI', 'Rua Calixto Barbieri - Iapi, Osasco - SP', 417);
GO

INSERT INTO turma (letraTurma)
VALUES ('A'), ('B'), ('C'), ('D'), ('E');
GO


INSERT INTO grauEscolar (nomeGrau)
VALUES ('Ensino Fundamental I'), ('Ensino Fundamental II'), ('Ensino Médio');
GO


INSERT INTO serie (idGrau, numeroSerie)
VALUES (1, '1ºano'), (1, '2ºano'), (1, '3ºano'), (1, '4ºano'), (1, '5ºano'),
(2, '6ºano'), (2, '7ºano'),(2, '8ºano'),(2, '9ºano'),
(3, '1ºano'), (3, '2ºano'), (3, '3ºano');
GO


INSERT INTO professor (idEscola, nomeProfessor, email, senha)
VALUES (1, 'Julio Ferreira', 'julio.ferreira@gmail,.com', 'j123');
GO

INSERT INTO aluno (idEscola, idSerie, idTurma, idFace, nomeAluno, cpf, rm, dataNascimento, foto)
VALUES (1, 12, 1, '7a31023c-acb3-44be-94e0-6c1c0bb8b036', 'Gustavo Borges', '49823562901', '4242', '28-08-2004', 'https://avatars.githubusercontent.com/u/82384564?v=4');
GO


