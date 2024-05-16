package com.LeQuangHuy.API.springboot.service;
import com.LeQuangHuy.API.springboot.model.CharacterUser;
import java.util.List;
import java.util.Optional;

public interface BookService {

    List<CharacterUser> getAllBooks();

    Optional<CharacterUser> getBookById(Long id);

    CharacterUser saveBook(CharacterUser characterUser);

    void deleteBook(Long id);
}
