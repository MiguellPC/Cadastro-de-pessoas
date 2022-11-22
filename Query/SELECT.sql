SELECT * FROM Pessoa
LEFT JOIN Endereco ON Endereco.ID = enderecoID
LEFT JOIN Telefone ON Telefone.ID = telefonesID
LEFT JOIN TipoTelefone ON TipoTelefone.ID = Telefone.tipoID
