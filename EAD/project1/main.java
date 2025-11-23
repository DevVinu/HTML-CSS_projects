package org.example;
import javax.swing.*;

public class Main extends JFrame {
    void main() {
        setTitle("My Application");
        setSize(400, 400);
        setDefaultCloseOperation(EXIT_ON_CLOSE);
        setLayout(null);

        JLabel lblName = new JLabel("Name:");
        lblName.setBounds(50, 50, 100, 30);
        add(lblName);

        JTextField txtName = new JTextField();
        txtName.setBounds(150, 50, 200, 30);
        add(txtName);

        JLabel lblAddress = new JLabel("Address:");
        lblAddress.setBounds(50, 100, 100, 30);
        add(lblAddress);

        JTextField txtAddress = new JTextField();
        txtAddress.setBounds(150, 100, 200, 30);
        add(txtAddress);

        JLabel lblUnits = new JLabel("Units Consumed:");
        lblUnits.setBounds(50, 150, 100, 30);
        add(lblUnits);

        JTextField txtUnits = new JTextField();
        txtUnits.setBounds(150, 150, 200, 30);
        add(txtUnits);

        JLabel lblType = new JLabel("Connection Type:");
        lblType.setBounds(50, 200, 100, 30);
        add(lblType);

        String[] types = {"Residential", "Commercial", "Industrial"};
        JComboBox<String> cmbType = new JComboBox<>(types);
        cmbType.setBounds(150, 200, 200, 30);
        add(cmbType);

        JButton btnCalculate = new JButton("Calculate Bill");
        btnCalculate.setBounds(150, 250, 150, 30);
        add(btnCalculate);

        JTextArea output = new JTextArea();
        output.setBounds(50, 300, 300, 100);
        add(output);

        btnCalculate.addActionListener(e -> {
            try {
                String name = txtName.getText();
                String address = txtAddress.getText();
                double units = Double.parseDouble(txtUnits.getText());
                String type = (String) cmbType.getSelectedItem();

                Customer customer = new Customer(name, address, units, type);
                ElectricityBill bill;

                switch (type) {
                    case "Residential":
                        bill = new ResidentialBill(customer, units);
                        break;
                    case "Commercial":
                        bill = new CommercialBill(customer, units);
                        break;
                    case "Industrial":
                        bill = new IndustrialBill(customer, units);
                        break;
                    default:
                        throw new IllegalArgumentException("Invalid connection type");
                }

                double total = bill.calculateBill();
                output.setText("Customer Name: " + name + "\n" +
                        "Address: " + address + "\n" +
                        "Units Consumed: " + units + "\n" +
                        "Connection Type: " + type + "\n" +
                        "Total Bill: $" + total);
            } catch (NumberFormatException ex) {
                JOptionPane.showMessageDialog(this, "Please enter valid numeric value for units consumed.", "Input Error", JOptionPane.ERROR_MESSAGE);
            }
        }
    }

    static void Main(String[] args) {
        SwingUtilities.invokeLater(() -> {
            Main app = new Main();
            app.setVisible(true);
        });
    }
}
