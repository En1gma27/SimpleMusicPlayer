package com.LeQuangHuy.API.springboot.repository;

import com.LeQuangHuy.API.springboot.model.Book;
import org.springframework.data.jpa.repository.JpaRepository;

public interface BookRepository extends JpaRepository<Book, Long> {

}
