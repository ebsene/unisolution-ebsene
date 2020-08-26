# Descrição

Projeto contendo um CRUD completo da tabela Tanque, contendo os campos:  
	* Deposito (este campo e a descrição e a chave)
	* Capacidade
	* TipoDeProduto
	
Este projeto foi desenvolvido utilizando o Asp.Net Boilerplate Web Application Framework e as práticas de design e desenvolvimento DDD (Domain-Driven Design) que não e uma tecnologia ou uma metodologia e nem esta restrito a uma só linguagem de programação ou tipo de projeto/arquitetura.
Sua utilização aproxima os especialistas do negócio ao time de desenvolvimento.


# Criação do banco de dados

Faça o download do projeto.  
Abra a solução contida na pasta "aspnet-core" no Visual Studio.  
Altere a string de conexão do banco de dados no arquivo appsettings.json, que se encontra dentro do projeto "UniSolution.Ebsene.Web.Host".  
Para gerar o banco de dados do projeto, acesse o Package Manager Console e execute os seguintes comandos:  
	1. Selecione o Default project "src\UniSolution.Ebsene.EntityFrameworkCore"
	2. Digite o comando "cd src" (sem as aspas)
	3. Digite o comando "cd .\UniSolution.Ebsene.EntityFrameworkCore" (sem as aspas)
	4. Digite o comando "Update-Database" (sem as aspas)
	
Após o banco de dados ser gerado, execute o projeto.  


# Informações de login

Usuário: admin  
Senha: 123qwe


# Licença

[MIT](LICENSE).
