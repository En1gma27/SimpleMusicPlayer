package com.LeQuangHuy.API.springboot.repository;

import com.LeQuangHuy.API.springboot.model.CharacterUser;
import org.springframework.data.jpa.repository.JpaRepository;

public interface BookRepository extends JpaRepository<CharacterUser, Long> {

}
