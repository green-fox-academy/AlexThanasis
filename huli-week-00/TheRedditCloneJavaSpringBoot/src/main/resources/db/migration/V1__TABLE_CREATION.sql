create table post
(
  id         bigint       not null
    primary key,
  content    varchar(255) null,
  created_at datetime     null,
  score      int          not null,
  url        varchar(255) null,
  user_id    bigint       not null
)

create table user
(
  id          bigint       not null
    primary key,
  description varchar(255) null,
  name        varchar(255) null,
  password    varchar(255) null,
  email       varchar(255) null
)

