create table post
(
  id         bigint       not null
  AUTO_INCREMENT,
  content    varchar(255) null,
  created_at datetime     null,
  score      int          null,
  url        varchar(255) null,
  user_id    bigint       null,
  PRIMARY KEY (id)
);

create table user
(
  id          bigint       not null
  AUTO_INCREMENT,
  description varchar(255) null,
  password    varchar(255) null,
  name        varchar(255) null,
  email       varchar(255) null,
  PRIMARY KEY (id)
)

