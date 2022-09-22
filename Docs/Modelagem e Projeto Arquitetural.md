### Diagrama de contexto

![Eletricharge-de contexto drawio](https://user-images.githubusercontent.com/81269914/191841098-8d33c7cf-b26a-406d-8c80-917591660b5c.png)

### Diagrama de container

![Eletricharge-de container drawio](https://user-images.githubusercontent.com/81269914/191841272-cf160653-59f6-4064-a999-ff36e9992dfb.png)


### Diagrama de componentes
![Eletricharge-de componente drawio](https://user-images.githubusercontent.com/81269914/191841322-920c1ba0-1ed6-498c-bda5-4c47842495e6.png)


### Plano de testes

<table>
 <tr>
  <th>RF/RNF</th>
  <th>Tipo</th>
  <th>Objetivo</th>
  <th>Passos</th>
  <th>Resultado esperado</th>
  <th>Status(Sucesso/Falha)</th>
 </tr>
 <tr>
  <td>RF-001</td>
  <td>Funcional</td>
  <td>Verificar se os usuários/adms podem entrar em suas contas, já criadas, sem problemas </td>
  <td>
   <ul>
       <li>Entrar no site</li>
       <li>Realizar o logon</li>
    </ul>
  </td>
  <td>O usuário/adm deverá entrar sem problemas na sua conta</td>
  <td></td>
 </tr>
 <tr>
  <td>RF-002</td>
  <td>Funcional</td>
  <td>Verificar se os usuários/adms podem sair de suas contas, já criadas, sem problemas </td>
  <td>
   <ul>
       <li>Entrar no site</li>
       <li>Caso não esteja logado,realizar o logon</li>
       <li> Realizar logoff </li>
    </ul>
  </td>
  <td>O usuário/adm deverá sair sem problemas de sua conta</td>
  <td></td>
 </tr>
 <tr>
  <td>RF-008</td>
  <td>Segurança</td>
  <td>Verificar se o usuário(não adm) consegue realizar o cadastro de veículos </td>
  <td>
   <ul>
       <li>Usuário deve logar/criar sua conta</li>
       <li>Tentar cadastrar um veículo</li>
    </ul>
  </td>
  <td>A opção para o cadastro não deverá estar disponível para o usuário</td>
  <td></td>
 </tr>
 <tr>
  <td>RNF-04</td>
  <td>Compatibilidade</td>
  <td>Verificar compatibilidade da aplicação com diferentes navegadores</td>
  <td>
   <ul>
       <li>O site deverá ser aberto em pelo menos dois nevagedores diferentes</li>
    </ul>
  </td>
  <td>A aplicação deverá carregar totalmente em todos os navegarores testados</td>
  <td></td>
 </tr>
 <tr>
  <td>RNF-07</td>
  <td>Segurança</td>
  <td>Verificar se as credenciais do adm estão corretamente aplicadas  </td>
  <td>
   <ul>
       <li>O adm deverá acessar sua conta</li>
       <li>Verificar se a opção de cadastrar carros está disponível</li>
    </ul>
  </td>
  <td>A opção de cadastrar veículo (elétricos e a combustão) deverá estar disponível assim que o adm fazer o logon</td>
  <td></td>
 </tr>
