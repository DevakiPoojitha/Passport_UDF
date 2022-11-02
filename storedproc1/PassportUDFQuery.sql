use MyDb
create table passport_Details(pas_no Bigint,cand_name varchar(20),pass_exp_date date,year_validity int,app_channel varchar(20));

select * from passport_Details

create or alter procedure Pass_Pooj @pass_num bigint,@candid_name varchar(20),@pass_expD date,@year_val int,@app_ch varchar(20) AS

insert into passport_Details(pas_no,cand_name,pass_exp_date,year_validity,app_channel)values (@pass_num,@candid_name,@pass_expD,@year_val,@app_ch)

exec Pass_Pooj 1232345,'poojitha','08-02-2032',10,'normal'