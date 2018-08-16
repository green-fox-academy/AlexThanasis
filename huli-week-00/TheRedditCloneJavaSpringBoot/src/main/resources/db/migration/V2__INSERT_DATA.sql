insert into user
(description, name, password, email)
values
('admin', 'Alex Admin', 'admin', 'rabbitowitz@gmail.com');

insert into user
(description, name, password, email)
values
('tester', 'Tester', '123', 'testman@test.hu');

insert into post
(user_id, content, score, url)
values
(1, "Cat pic OK", 3, "https://http.cat/100");
