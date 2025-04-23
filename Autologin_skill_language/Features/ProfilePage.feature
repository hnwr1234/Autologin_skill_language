Feature: Profile Page
  As a user
  I want to add languages and skills to my profile
  So that I can maintain my profile information

  Background: 
    Given I am logged in and on the profile page

  Scenario: Add languages to the profile
    Given I navigate to the profile page
    When I add the following languages to my profile:
      | Language  | Level           |
      | English   | Fluent          |
      | Mandarin  | Fluent          |
      | Cantonese | Native/Bilingual|
      | Japanese  | Fluent          |
    Then the languages should be added successfully

  Scenario: Add skills to the profile
    Given I navigate to the profile page
    When I add the following skills to my profile:
      | Skill      | Level    |
      | Python     | Beginner|
      | Java       | Beginner|
      | JavaScript | Beginner|
      | HTML       | Beginner|
      | CSS        | Beginner|
    Then the skills should be added successfully
