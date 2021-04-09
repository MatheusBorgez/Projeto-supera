# Projeto-supera
Projeto feito em C# para processo seletivo da empresa Supera

#### Tecnologias usadas: ***C#, ASP.NET MVC, JavaScript, Razor pages, (banco de dados a definir).***

#### **Problema:**

Fred precisa conferir diariamente um arquivo padronizado com dados de diversos produtos que as empresas fornecem para ele, o Fred sempre tem que identificar quais produtos estão com uma quantidade em estoque inferior a uma determinada quantidade e também quais produtos tem o seu preço de venda com uma margem de lucro inferior a uma determinada porcentagem.

 

Além disso, o Fred também precisa de buscar um determinado produto por nome e alterar alguns de seus dados.

Hoje Fred faz isso importando o arquivo para o EXCEL, assim ele utiliza todos os recursos do EXCEL para navegar nos dados, filtrar os registros, descobrir a margem de lucro do produto, editar os dados e etc.

Fred contratou nossa empresa para desenvolver uma Plataforma WEB feita em C# para resolver seu problema.

#### **Requisitos:**

* Acesso por Usuário e Senha;
* Ao subir a plataforma a mesma já deve ter um usuário padrão registrado no banco de dados, com login: admin e senha: admin;
* Importação do arquivo;
* Dados devem ser persistidos em banco de dados;
* Exibição dos dados importados, onde o Fred quer poder filtrar os dados de acordo com a necessidade apresentada no texto;
* Edição de registro para corrigir possível erros de digitação ou valores incorretos;
* A edição deve ser em todos os dados, exceto: Id e Data do Cadastro;
* Exportação de todos os dados analisados/alterados no mesmo formato do arquivo original importado;
* Após a exportação os dados existentes no banco de dados devem ser apagados;

#### **Diferencial avaliativo:**

* Normatização das tabelas e dados;
* Utilização de indexes e recursos do banco de dados;
* Utilização de Docker para rodar o projeto;
* Patterns e SOLID;

#### **Entrega:**

* O desafio deve ser entregue até o dia 14/04, às 23:59

* A entrega deve ser por Repositório GIT ou Anexo (em ambos os casos enviar um e-mail com a URL ou Anexo e detalhes da entrega);
