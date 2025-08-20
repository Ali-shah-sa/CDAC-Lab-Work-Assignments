// AccountList.js
import React from 'react';

const ProductList = ({ productArray, handleDelete }) => {
  return (
    <div className='border m-2 p-5'>
      <h2 className='text-center'>Product List</h2>
      <br></br>
      {productArray.length === 0 ? (
        <p>No Products to display.</p>
      ) : (
        <table className="table table-bordered">
          <thead>
            <tr>
              <th>Product ID</th>
              <th>Product Name</th>
              <th>Price</th>
              <th>Expiry Date</th>
              <th>Action</th>
            </tr>
          </thead>
          <tbody>
            {productArray.map((product, index) => (
              <tr key={index}>
                <td>{product.productId}</td>
                <td>{product.productName}</td>

                <td>{product.price}</td>
                <td>{product.Date}</td>
                <td>
                  
                  <button
                    className="btn btn-danger btn-sm"
                    onClick={() => handleDelete(index)}
                  >
                    Delete
                  </button>
                </td>
              </tr>
            ))}
          </tbody>
        </table>
      )}
    </div>
  );
};

export default ProductList;
