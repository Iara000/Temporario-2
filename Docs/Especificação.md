### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade | Dificuldade |
|------|-----------------------------------------|----|---| 
|RF-001| Permitir que o administrador/usuários efetue Logon no sistema | ALTA | M |
|RF-002| Permitir que o administrador/usuários efetue Logoff no sistema | ALTA | M |
|RF-003| Permitir que o usuário encontre eletropostos disponíveis no Brasil | ALTA | A |
|RF-004| Ao final do cálculo, oferecer opção para o usuário compartilhar o resultado nas redes sociais | MEDIA | A |
|RF-005| Permitir que o usuário escolha o modelo do veículo (elétricos e a combustão) entre as opções cadastradas | MEDIA | M |
|RF-006??| Permitir que o administrador realize o cadastro de usuários | MEDIA | M |
|RF-007| Criar 3 tipos de calculadora para escolha do usuario | MÉDIA | B |
|RF-008| Permitir que o administrador/usuários realize o cadastro de veículos (elétricos e a combustão) | BAIXA | M |
|RF-009| Permitir recuperação de login| BAIXA | M |
|RF-010| Restrição de extensão do arquivo do upload de imagens| BAIXA | M|
|RF-011| Restrição de tamanho de arquivo do upload de imagens | BAIXA | M |
|RF-012| Realizar os cálculos necessários para comparação da autonomia e custo beneficio entre carros elétricos x combustão | BAIXA | B |
|RF-013| Cada campo do formulário deve ser validado quanto ao tipo de dado (inteiro/real/caractere) | BAIXA | B |
|RF-014| Criar menu para exibição das alternativas de cálculo | BAIXA | B |
|RF-015| Cada campo de formulário que possa gerar dúvida deve possuir um icone de ajuda | BAIXA | B |



### Requisitos não Funcionais

- RNF 01- Padrões- Utilizar o SCRUM como metodologia de desenvolvimento
- RNF 02- Confiabilidade- As permissões de acesso ao sistema podem ser alteradas apenas pelo administrador de sistemas
- RNF 03- Usabilidade-Interface Intuitiva e Reativa
- RNF 04- Compatibilidade- O sistema deve funcionar em todos os principais navegadores (Chrome, mozila e Edge)
- RNF 05- Compatibilidade- O sistema deve ser responsivo para executar em dispositivos móveis
- RNF 06- Desempenho- Deve processar requisições do usuário em no máximo 5s
- RNF 07- Segurança- O sistema deve permitir ao usuário realizar a autenticação e autorização de entrada no sistema através de login e senha

### Restrições Arquiteturais

- R1: O front-end deve ser desenvolvido com a linguagem de programação JavaScript e para isso deve ser utilizado a biblioteca React na versão mais recente;
- R2: Para a padronização da interface deve ser seguido o guia de estilo do framework Bootstrap;
- R3: O mecanismo de autorização entre as APIs deverá ser feito por meio do JWT;
- R4: A aplicação deve ser hospedada no serviço de nuvem AWS;  

### Mecanismos Arquiteturais

|Análise | Design  | Implementação |
|--------|--------------------|----|
|Front-end |Biblioteca de programação | React|
|Front-end |Linguagem de programação | JavaScript|
|Front-end |Framework de folha de estilo | Bootstrap|
|Deploy |Plataforma de automatização de deploy | AWS|
|Back-end |Linguagem de programação | C# |
|Back-end |Framework | Node.js |
|Back-end |Gerenciador de tráfego |Amazon API Gateway |
|Autenticação |Padrão de formato para autenticação | JWT|
|Integração |Protocolo de comunicação | HTTP |
|Integração |Estilo de arquitetura | REST |
|Versionamento |Controle e armazenamento de código fonte | Github|
|Automação | Ferramenta de workflow | Figma, Lucidchart |
|Build |Ferramenta de build de componentes do software |NPM |
