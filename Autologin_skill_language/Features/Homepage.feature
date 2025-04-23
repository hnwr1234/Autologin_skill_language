Feature: Home Page Access http://localhost:5003/Home

  Scenario: Valid user logs into the home page http://localhost:5003/Home
    Given the user launches the application
    When the user logs in with valid credentials
    Then the home page is displayed
