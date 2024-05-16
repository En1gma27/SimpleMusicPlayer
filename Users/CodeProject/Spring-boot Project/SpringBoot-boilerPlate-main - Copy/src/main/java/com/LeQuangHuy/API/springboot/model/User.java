package com.rimmelasghar.boilerplate.springboot.model;

import lombok.*;

import javax.persistence.*;

// rimmel asghar
@Getter
@Setter
@Entity
@Builder
@NoArgsConstructor
@AllArgsConstructor
@Table(name = "USERS")
public class User {

	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	private Long id;


	@Column(unique = true)
	private String username;

	private String password;

	private String email;
	private String Address;

	@Enumerated(EnumType.STRING)
	private UserRole userRole;

	// Getter và Setter cho thuộc tính username
	public String getUsername() {
		return username;
	}

	public void setUsername(String username) {
		this.username = username;
	}

	// Getter và Setter cho thuộc tính password
	public String getPassword() {
		return password;
	}

	public void setPassword(String password) {
		this.password = password;
	}

	// Getter và Setter cho thuộc tính email
	public String getEmail() {
		return email;
	}

	public void setEmail(String email) {
		this.email = email;
	}

	// Getter và Setter cho thuộc tính Address
	public String getAddress() {
		return Address;
	}

	public void setAddress(String address) {
		Address = address;
	}

	// Getter và Setter cho thuộc tính userRole
	public UserRole getUserRole() {
		return userRole;
	}

	public void setUserRole(UserRole userRole) {
		this.userRole = userRole;
	}

}
