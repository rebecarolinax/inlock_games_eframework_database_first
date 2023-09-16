# InLock_EFrameWork_DataBase 📚
Uma empresa do ramo de games, a **InLock**, deseja realizar a criação de sua base de dados
para armazenar os **jogos que são vendidos em sua loja**. Além disso, como eles já
possuem um desenvolvedor Front-End atuando na empresa, **não será necessário**
construir a interface com o usuário final. Para isto, deverá ser **desenvolvida uma API**
(trabalhando com JSON), para que o Front-End (seja web ou mobile) realize a construção
com base nas informações fornecidas.

## Conceituando sobre a estrutura DataBase do Entity Framework (EF) 📏
O **Entity Framework Database Firs**t é uma abordagem de desenvolvimento de aplicativos que faz parte do Entity Framework, um framework de **mapeamento objeto-relacional (ORM)** desenvolvido pela Microsoft. A principal diferença entre o **Entity Framework Database First** e o **Entity Framework Code First** é que, no Database First, o modelo de dados é gerado automaticamente a partir de um banco de dados existente, enquanto no Code First, você define o modelo de dados usando código C# (ou outra linguagem suportada) e, em seguida, o banco de dados é criado com base nesse modelo.
##
**Aqui estão os conceitos-chave do Entity Framework Database First:**

**• Modelo de Dados a partir do Banco de Dados:** No Entity Framework Database First, o modelo de dados é criado a partir de um banco de dados existente. Isso significa que as classes de entidade e os relacionamentos são gerados automaticamente com base nas tabelas, colunas e chaves estrangeiras do banco de dados.

**• Geração de Código Automática:** O Entity Framework pode gerar automaticamente as classes de entidade (modelos) a partir do esquema do banco de dados. Essas classes representam as tabelas do banco de dados e são decoradas com atributos que definem o mapeamento entre as entidades e as tabelas.

**• Edição do Modelo Gerado:** Depois de gerar o modelo de dados a partir do banco de dados, você pode personalizá-lo conforme necessário. Isso pode incluir adicionar métodos personalizados às classes de entidade, aplicar validações de dados e adicionar outras lógicas de negócios.

**• Contexto do Banco de Dados:** Assim como no Entity Framework Code First, você cria uma classe de contexto de banco de dados que herda de DbContext. O contexto do banco de dados é responsável por gerenciar a conexão com o banco de dados, rastrear alterações nas entidades e realizar operações de consulta e atualização no banco de dados.

**• Atualizações de Banco de Dados:** O Entity Framework Database First também suporta atualizações de banco de dados. Isso significa que, se você fizer alterações no banco de dados (por exemplo, adicionar ou remover tabelas ou colunas), você pode regerar o modelo de dados a partir do banco de dados para refletir essas alterações.

##
O **Entity Framework Database First** é especialmente útil quando você está trabalhando com um banco de dados existente ou quando precisa criar um modelo de dados a partir de um esquema de banco de dados existente. Ele permite que você aproveite os recursos e a estrutura de um banco de dados existente e comece a desenvolver seu aplicativo a partir daí, sem a necessidade de definir manualmente todas as classes de entidade e relacionamentos.
