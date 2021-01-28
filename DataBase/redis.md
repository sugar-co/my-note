# redis

## NoSql

特征

* 可扩容，可伸缩
* 大数据量

## String

```
set
get
strlen
mget
mset
append
del

incr
incrby
incrbyfloat

decr
decrby

setex
psetex
```

## Hash

```
hset
hget
hgetall
hdel

hmset
hmget
hlen
hexists

hkeys
hvals

hincrby
hincybyfloat

hsetnx
```

## List

```
lpush
rpush
lpushx
rpushx

lrange
lindex
LINSERT 
llen

lpop
rpop
BRPOPLPUSH

blpop key1 [key2] timeout
brpop

lrem key count value
```

## Set

```

```



## stream





+ + EXPIRE key "seconds"
+ PEXPIRE key "milliseconds"
+ ttl
+ pttl

[过期时间](https://www.cnblogs.com/xiaoxiongcanguan/p/9937433.html?utm_source=tuicool&utm_medium=referral)

## cluster

```shell
redis-cli --cluster create 127.0.0.1:30001 127.0.0.1:30002 127.0.0.1:30003 127.0.0.1:30004 127.0.0.1:30005 127.0.0.1:30006 127.0.0.1:30007 127.0.0.1:30008 127.0.0.1:30009 127.0.0.1:30010 --cluster-replicas 1
```

