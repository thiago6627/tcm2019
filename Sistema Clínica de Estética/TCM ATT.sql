Create database TcmClinica

Use TcmClinica


/* Cliente */

create table tbl_cliente (
nmcli varchar(80) not null,
emailcli varchar(80) not null,
cpfcli varchar(30) not null,
sexo char (30) not null,
ntel varchar(20) not null,
primary key (cpfcli) 
)

drop table tbl_cliente

insert into tbl_cliente

(nmcli, emailcli, cpfcli, ntel, sexo) 
values ('Julio','julio.anasdij@gmail.com','000.000.000-00','39039504','Masculino')

SELECT * FROM tbl_cliente where cpfcli= '000.000.000-00'

select * from tbl_cliente

delete from tbl_cliente



									  /*Fornecdeor*/

create table tbl_fornecedor (
codfornec int identity(1,1) not null,
nmfornec varchar(80) not null,
enderecoforn varchar(80) not null,
emailforn varchar(80) not null,
cnpj varchar (15) not null,
telforn varchar(20) not null,
codprodt int not null, 
foreign key(codprodt) references tbl_produto(codprodt),
primary key (codfornec),
)
	
insert into tbl_fornecedor
(nmfornec, enderecoforn, emailforn, cnpj, telforn) values ('Bernadete Lima','Rua Emilio colela 654','ber.lima@gmail.com','54789547865421','11987546870')

drop table tbl_fornecedor


										/*Produto */

create table tbl_produto (
codprodt int identity(1,1) not null primary key , 
nmprodt varchar (50) not null,
dsprodt varchar (80)
)

drop table tbl_produto

select* from tbl_produto

insert into tbl_produto
(nmprodt,dsprodt) values ('Cera','Utilizado para serviços como depilação.')

INSERT INTO tbl_produto (nmprodt) values ('Argila')
INSERT INTO tbl_produto (nmprodt) values ('Base')
INSERT INTO tbl_produto (nmprodt) values ('Batom')
INSERT INTO tbl_produto (nmprodt) values ('BB Cream')
INSERT INTO tbl_produto (nmprodt) values ('Blush')
INSERT INTO tbl_produto (nmprodt) values ('Bronzeador Instantâneo')
INSERT INTO tbl_produto (nmprodt) values ('Bronzeador Spray')
INSERT INTO tbl_produto (nmprodt) values ('Cera Aloe Vera')
INSERT INTO tbl_produto (nmprodt) values ('Cera de Abacata')
INSERT INTO tbl_produto (nmprodt) values ('Cera de Choc. Branc')
INSERT INTO tbl_produto (nmprodt) values ('Cera de Coco')
INSERT INTO tbl_produto (nmprodt) values ('Cera Negra')
INSERT INTO tbl_produto (nmprodt) values ('Cera (em grânulos)')
INSERT INTO tbl_produto (nmprodt) values ('Cera (Roll On)')
INSERT INTO tbl_produto (nmprodt) values ('Cílios Postiço')
INSERT INTO tbl_produto (nmprodt) values ('Cola / Drenagem')
INSERT INTO tbl_produto (nmprodt) values ('Corretivo')
INSERT INTO tbl_produto (nmprodt) values ('Creme p/ Drenagem')
INSERT INTO tbl_produto (nmprodt) values ('Delineador')
INSERT INTO tbl_produto (nmprodt) values ('Espátula')
INSERT INTO tbl_produto (nmprodt) values ('Gloss')
INSERT INTO tbl_produto (nmprodt) values ('Iluminador')
INSERT INTO tbl_produto (nmprodt) values ('Lápis de Olho')
INSERT INTO tbl_produto (nmprodt) values ('Lápis de Sombracelha')
INSERT INTO tbl_produto (nmprodt) values ('Linha p/ Depilação')
INSERT INTO tbl_produto (nmprodt) values ('Máscara de Cílios')
INSERT INTO tbl_produto (nmprodt) values ('Óleo (Pós depil.)')
INSERT INTO tbl_produto (nmprodt) values ('Palito')
INSERT INTO tbl_produto (nmprodt) values ('Pincéis')
INSERT INTO tbl_produto (nmprodt) values ('Pó Compacto')
INSERT INTO tbl_produto (nmprodt) values ('Primer')
INSERT INTO tbl_produto (nmprodt) values ('Removedor (Pós Depil.)')
INSERT INTO tbl_produto (nmprodt) values ('Sombra')



								  	/* Funcionario */

create table tbl_funcionario (
codfunc int identity(1,1) not null,
nmfunc varchar(80) not null,
cargo varchar(30) not null,
salario varchar(10) not null,
enderecofunc varchar(80) not null,
emailfunc varchar(80) not null,
cpffunc varchar(15) not null,
rgfunc varchar (15) not null,
dataadim varchar(10) not null,
telfunc varchar(15),
celfunc varchar(15) not null,
datanasc varchar(15) not null,
sexo char (9) not null,
primary key (codfunc) 
)

drop table tbl_funcionario
delete from tbl_funcionario where cpffunc = '111.111.111-11'

select * from tbl_funcionario


insert into tbl_funcionario (nmfunc,cargo,salario,enderecofunc,emailfunc,cpffunc,telfunc,datanasc)
values ('Julio Duvique','CEO','5356.58','Alameda das laranjas', 'julio.andriollo@etec.sp.gov.br','54678978909','11970186861','2002/08/06') 

update tbl_funcionario 	set sexo = 'Masculino' 	where cpffunc='000.000.000-00'														       

alter tbl_funcionario 																		   
							         /* Pagamento */

create table tbl_pagamento (
vlpag varchar(20) not null,
codpag int primary key identity(1,1) not null,
formapag char (8) not null,
cpfcli varchar(30),
datapag date not null,
foreign key(cpfcli) references tbl_cliente(cpfcli)
)

drop table tbl_pagamento
insert into tbl_pagamento (vlpag,formapag) values ('')

select * from tbl_pagamento		
select p.vlpag,p.codpag,p.formapag,p.cpfcli,p.datapag,c.nmcli from tbl_cliente as c inner join tbl_pagamento as p on p.cpfcli = c.cpfcli
																			
									  /* Serviços */

create table tbl_servico (
nmserv varchar (80) not null,
tiposerv varchar (100) not null,
codprodt int ,
codfunc int ,
codserv int primary key identity(1,1) not null,
vlserv varchar(20) , 
foreign key (codprodt) references tbl_produto(codprodt),
foreign key (codfunc) references tbl_funcionario(codfunc)
)

select * from tbl_servico

Insert into tbl_servico values ('Pao','Batata','1','8','')
update tbl_servico  set vlserv = '10' where nmserv='Pao'
INSERT INTO tbl_servico (nmserv,tiposerv,codprodt,codfunc) values ('Drenagem Linfática','Tratamento Corporal','1','8')
INSERT INTO tbl_servico (nmserv,tiposerv,codprodt,codfunc) values ('Heccus','Tratamento Corporal','5','')
INSERT INTO tbl_servico (nmserv,tiposerv,codprodt,codfunc) values ('Lipo Carbox','Tratamento Corporal','6','')
INSERT INTO tbl_servico (nmserv,tiposerv,codprodt,codfunc) values ('Lipo Massagem','Tratamento Corporal','8','')
INSERT INTO tbl_servico (nmserv,tiposerv,codprodt,codfunc) values ('Massagem','Tratamento Corporal','2','')
INSERT INTO tbl_servico (nmserv,tiposerv,codprodt,codfunc) values ('Plataforma Vibratória','Tratamento Corporal','20','')
INSERT INTO tbl_servico (nmserv,tiposerv,codprodt,codfunc) values ('Reflexologia Podal','Tratamento Corporal','29','')
INSERT INTO tbl_servico (nmserv,tiposerv,codprodt,codfunc) values ('Shiatsu','Tratamento Corporal','31','')
INSERT INTO tbl_servico (nmserv,tiposerv,codprodt,codfunc) values ('Spectra','Tratamento Corporal','15','')

INSERT INTO tbl_servico (nmserv,tiposerv,codprodt,codfunc) values ('Dermaroller','Tratamento Facial','','')
INSERT INTO tbl_servico (nmserv,tiposerv,codprodt,codfunc) values ('Eletrolifting','Tratamento Facial','','')
INSERT INTO tbl_servico (nmserv,tiposerv,codprodt,codfunc) values ('Hidratação Facial ','Tratamento Facial','','')
INSERT INTO tbl_servico (nmserv,tiposerv,codprodt,codfunc) values ('Limpeza de Pele','Tratamento Facial ','','')
INSERT INTO tbl_servico (nmserv,tiposerv,codprodt,codfunc) values ('Peeling','Tratamento Facial','','')
INSERT INTO tbl_servico (nmserv,tiposerv,codprodt,codfunc) values ('Peeling Amazônico','Tratamento Facial','','')
INSERT INTO tbl_servico (nmserv,tiposerv,codprodt,codfunc) values ('Peeling de Diamante','Tratamento Facial','','')
INSERT INTO tbl_servico (nmserv,tiposerv,codprodt,codfunc) values ('Peeling Vulcanice','Tratamento Facial','','')
INSERT INTO tbl_servico (nmserv,tiposerv,codprodt,codfunc) values ('Spectra','Tratamento Facial ','','')

INSERT INTO tbl_servico (nmserv,tiposerv,codprodt,codfunc) values ('Cabelo e Maquiagem','Tratamento Especial','','','')
INSERT INTO tbl_servico (nmserv,tiposerv,codprodt,codfunc) values ('Depilação Egípcia','Tratamento Especial','','','')
INSERT INTO tbl_servico (nmserv,tiposerv,codprodt,codfunc) values ('Dia da Noiva','Tratamento Especial','','','')
INSERT INTO tbl_servico (nmserv,tiposerv,codprodt,codfunc) values ('Dia de SPA','Tratamento Especial','','','')
INSERT INTO tbl_servico (nmserv,tiposerv,codprodt,codfunc) values ('Dia do Noivo','Tratamento Especial','','','')
INSERT INTO tbl_servico (nmserv,tiposerv,codprodt,codfunc) values ('Emagrecimento e Nutrição','Tratamento Especial','','','')

INSERT INTO tbl_servico (nmserv,tiposerv,codprodt,codfunc) values ('Bronzeamento Artificial','Tratamentos Diversos','','','')
INSERT INTO tbl_servico (nmserv,tiposerv,codprodt,codfunc) values ('Depilação','Tratamentos Diversos','','','')
INSERT INTO tbl_servico (nmserv,tiposerv,codprodt,codfunc) values ('Maquiagem Definitiva','Tratamentos Diversos','','','')
INSERT INTO tbl_servico (nmserv,tiposerv,codprodt,codfunc) values ('Salão de Beleza','Tratamentos Diversos','','','')

drop table tbl_servico


select * from tbl_servico



									 /* Agendamento */

create table tbl_agendamento(
data date,
codsessao  int  primary key identity(1,1),
hora varchar(10),
cpfcli varchar(30) ,
codserv int,
foreign key (cpfcli) references tbl_cliente(cpfcli),
foreign key(codserv) references tbl_servico(codserv)
)

drop table tbl_agendamento

select*from tbl_agendamento

SELECT s.nmserv,s.tiposerv from tbl_agendamento as a inner join tbl_servico as s on  a.codserv = s.codserv where a.codserv= 3


										/* Estoque */

create table tbl_estoque (
codprodt int not null,
quantmax int not null,
quantmin int not null,
qtatual int not null,
foreign key (codprodt) references tbl_produto (codprodt)
)

select * from tbl_estoque

drop table tbl_estoque

update tbl_estoque set qtatual = 99 where codprodt= 5

INSERT INTO tbl_estoque (codprodt,quantmax,quantmin,qtatual) values ('1','100','0','50')
INSERT INTO tbl_estoque (codprodt,quantmax,quantmin,qtatual) values ('2','100','0','50')
INSERT INTO tbl_estoque (codprodt,quantmax,quantmin,qtatual) values ('3','100','0','50')
INSERT INTO tbl_estoque (codprodt,quantmax,quantmin,qtatual) values ('4','100','0','50')
INSERT INTO tbl_estoque (codprodt,quantmax,quantmin,qtatual) values ('5','100','0','50')
INSERT INTO tbl_estoque (codprodt,quantmax,quantmin,qtatual) values ('6','100','0','50')
INSERT INTO tbl_estoque (codprodt,quantmax,quantmin,qtatual) values ('7','100','0','50')
INSERT INTO tbl_estoque (codprodt,quantmax,quantmin,qtatual) values ('8','100','0','50')
INSERT INTO tbl_estoque (codprodt,quantmax,quantmin,qtatual) values ('9','100','0','50')
INSERT INTO tbl_estoque (codprodt,quantmax,quantmin,qtatual) values ('10','100','0','50')
INSERT INTO tbl_estoque (codprodt,quantmax,quantmin,qtatual) values ('11','100','0','50')
INSERT INTO tbl_estoque (codprodt,quantmax,quantmin,qtatual) values ('12','100','0','50')
INSERT INTO tbl_estoque (codprodt,quantmax,quantmin,qtatual) values ('13','100','0','50')
INSERT INTO tbl_estoque (codprodt,quantmax,quantmin,qtatual) values ('14','100','0','50')
INSERT INTO tbl_estoque (codprodt,quantmax,quantmin,qtatual) values ('15','100','0','50')
INSERT INTO tbl_estoque (codprodt,quantmax,quantmin,qtatual) values ('16','100','0','50')
INSERT INTO tbl_estoque (codprodt,quantmax,quantmin,qtatual) values ('17','100','0','50')
INSERT INTO tbl_estoque (codprodt,quantmax,quantmin,qtatual) values ('18','100','0','50')
INSERT INTO tbl_estoque (codprodt,quantmax,quantmin,qtatual) values ('19','100','0','50')
INSERT INTO tbl_estoque (codprodt,quantmax,quantmin,qtatual) values ('20','100','0','50')
INSERT INTO tbl_estoque (codprodt,quantmax,quantmin,qtatual) values ('21','100','0','50')
INSERT INTO tbl_estoque (codprodt,quantmax,quantmin,qtatual) values ('22','100','0','50')
INSERT INTO tbl_estoque (codprodt,quantmax,quantmin,qtatual) values ('23','100','0','50')
INSERT INTO tbl_estoque (codprodt,quantmax,quantmin,qtatual) values ('24','100','0','50')
INSERT INTO tbl_estoque (codprodt,quantmax,quantmin,qtatual) values ('25','100','0','50')
INSERT INTO tbl_estoque (codprodt,quantmax,quantmin,qtatual) values ('26','100','0','50')
INSERT INTO tbl_estoque (codprodt,quantmax,quantmin,qtatual) values ('27','100','0','50')
INSERT INTO tbl_estoque (codprodt,quantmax,quantmin,qtatual) values ('28','100','0','50')
INSERT INTO tbl_estoque (codprodt,quantmax,quantmin,qtatual) values ('29','100','0','50')
INSERT INTO tbl_estoque (codprodt,quantmax,quantmin,qtatual) values ('30','100','0','50')
INSERT INTO tbl_estoque (codprodt,quantmax,quantmin,qtatual) values ('31','100','0','50')
INSERT INTO tbl_estoque (codprodt,quantmax,quantmin,qtatual) values ('32','100','0','50')
INSERT INTO tbl_estoque (codprodt,quantmax,quantmin,qtatual) values ('33','100','0','50')

select p.codprodt,p.nmprodt, e.qtatual from tbl_estoque as e inner join tbl_produto as p on  e.codprodt = p.codprodt

select a.data, a.hora,a.codsessao,a.cpfcli, s.nmserv,a.codserv from tbl_agendamento as a inner join tbl_servico as s on  a.codserv = s.codserv