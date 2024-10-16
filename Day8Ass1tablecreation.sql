Create table customer (
	id int primary key identity,
	name varchar(50) not null,
	email varchar(50) unique not null,
	adress varchar(100) not null,
	dob date not null
)

create table accounts (
	id int primary key identity,
	acc_type varchar(50) not null,
	account_nu varchar(15) unique not null,
	cust_id int not null,
	acc_date date not null default getdate(),
	constraint FK_accounts_cust_id foreign key (cust_id) references customer(id)
);

create table transactions (
	id int primary key identity,
	account_id int not null,
	transation_type varchar(50) not null,
	amount decimal(10,3) not null,
	to_account_id INT ,
	tras_date date not null default getdate(),
	constraint FK_trans_account_id foreign key (account_id) references accounts(id),
	constraint FK_trans_to_account_id foreign key (to_account_id) references Accounts(id)
);