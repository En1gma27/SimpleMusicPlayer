package com.LeQuangHuy.API.springboot.service.Impl;
import com.LeQuangHuy.API.springboot.model.CharacterUser;
import com.LeQuangHuy.API.springboot.repository.BookRepository;
import com.LeQuangHuy.API.springboot.service.BookService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.Optional;

@Service
public class BookServiceImpl implements BookService {

    private final BookRepository bookRepository;

    @Autowired
    public BookServiceImpl(BookRepository bookRepository) {
        this.bookRepository = bookRepository;
    }

    @Override
    public List<CharacterUser> getAllBooks() {
        return bookRepository.findAll();
    }

    @Override
    public Optional<CharacterUser> getBookById(Long id) {
        return bookRepository.findById(id);
    }

    @Override
    public CharacterUser saveBook(CharacterUser characterUser) {
        return bookRepository.save(characterUser);
    }

    @Override
    public void deleteBook(Long id) {
        bookRepository.deleteById(id);
    }
}
