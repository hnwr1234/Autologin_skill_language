Feature: Login Page
  As a user of the  I want to enter my skill & language in my profile page
  I want to log in with valid credentials
  So that I can access my homepage

  Background:
    Given I navigate to the login page
    And I click the "Sign In" link

  Scenario: Successful login with valid credentials
    When I enter a valid email and password
    And I click the login button
    Then I should be redirected to the homepage

  Scenario: Unsuccessful login with invalid credentials
    When I enter an invalid email and password
    And I click the login button
    Then I should see an error message on the login page
