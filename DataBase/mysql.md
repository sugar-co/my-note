# mysql

## 完整的SELECT 

```c#
这才是完整的SELECT查询
SELECT DISTINCT column, AGG_FUNC(column_or_expression), …
FROM mytable
    JOIN another_table
    ON mytable.column = another_table.column
    WHERE constraint_expression
    GROUP BY column
    HAVING constraint_expression
    ORDER BY column ASC/DESC
    LIMIT count OFFSET COUNT;
```



## case when

```c#
第一种 格式 : 简单Case函数 :

格式说明    

　　　　case 列名

　　　　when   条件值1   then  选项1

　　　　when   条件值2    then  选项2.......

　　　　else     默认值      end

eg:

　　　　select 
　　　　case 　　job_level
　　　　when     '1'     then    '1111'
　　　　when　  '2'     then    '1111'
　　　　when　  '3'     then    '1111'
　　　　else       'eee' end
　　　　from     dbo.employee
```

```c#
 第二种  格式 :Case搜索函数

格式说明    

　　　　case  

　　　　when  列名= 条件值1   then  选项1

　　　　when  列名=条件值2    then  选项2.......

　　　　else    默认值 end

eg:

　　　　update  employee
　　　　set         e_wage =
　　　　case
　　　　when   job_level = '1'    then e_wage*1.97
　　　　when   job_level = '2'   then e_wage*1.07
　　　　when   job_level = '3'   then e_wage*1.06
　　　　else     e_wage*1.05
　　　　end
```

## explain

## 导入表

[牛客题目链接](https://www.nowcoder.com/practice/881385f388cf4fe98b2ed9f8897846df?tpId=82&tags=&title=&diffculty=0&judgeStatus=0&rp=1)

```sql
-- sqllit
create table actor_name as
select first_name,last_name from actor

-- mysql
create table actor_name
select first_name,last_name from actor
```

